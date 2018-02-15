using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore{

    public class CalculatorCore {

        private string hidden = "";
        private Status status = new Status();

        private InputType current_operator = InputType.None;
        private InputType CurrentOperator {
            get {
                return isOperator(current_operator) ? current_operator : InputType.None;
            }
        }

        private StringBuilder display_value = new StringBuilder();
        public string DisplayValue {
            get {
                if (status.Is(Status.Flag.Result_Display)) return hidden;
                else return display_value.Length > 0 ? display_value.ToString() : "0";
            }
        }

        public static InputType[] operators = { InputType.Sub, InputType.Add, InputType.Div, InputType.Eq, InputType.Mul };

        public CalculatorCore() {

        }

        public void Input(InputType input) {
            if (!isOperator(input)) {
                if (status.Is(Status.Flag.Result_Display)) {
                    status.Off(Status.Flag.Result_Display);
                }

                if (status.Is(Status.Flag.Operator_Just_Pressed)) {
                    display_value.Clear();
                    status.Off(Status.Flag.Operator_Just_Pressed);
                }

                if (_isNumbers(input)) {
                    _Numbers(input);
                } else {
                    _SpecialSymbols(input);
                }
            } else {
                if (display_value.Length == 0) {
                    display_value.Append("0");
                }

                _Operate(input);
            }
        }

        private bool _isNumbers(InputType input) {
            return (int)input > 0 && (int)input < 10;
        }
        private void _Numbers(InputType input) {
            display_value.Append((int)input);
        }

        private void _SpecialSymbols(InputType input) {
            switch (input) {
                case InputType.Num0:
                    if (display_value.Length > 0) display_value.Append("0");
                    break;
                case InputType.Num00:
                    if (display_value.Length > 0) display_value.Append("00");
                    break;
                case InputType.Dot:
                    if (status.Is(Status.Flag.Dotted)) break;
                    if (display_value.Length > 0) {
                        display_value.Append(".");
                    } else {
                        display_value.Append("0.");
                    }
                    status.On(Status.Flag.Dotted);
                    break;
            }
        }

        private void _Operate(InputType input) {
            if (input == InputType.Eq) {
                _Calculate(current_operator);
            } else if(isOperator(input)){
                if (status.Is(Status.Flag.Operator_Pressed)) {
                    _Calculate(current_operator);
                } else {
                    if (status.IsNot(Status.Flag.Result_Display)) {
                        hidden = display_value.ToString();
                    }
                    status.ResetExcept(Status.Flag.Result_Display);
                }
                current_operator = input;
                status.On(Status.Flag.Operator_Pressed | Status.Flag.Operator_Just_Pressed);
            }
        }

        private void _Calculate(InputType input) {
            switch (input) {
                case InputType.Add:
                    hidden = Convert.ToString(Convert.ToDouble(hidden) + Convert.ToDouble(display_value.ToString()));
                    break;
                case InputType.Sub:
                    hidden = Convert.ToString(Convert.ToDouble(hidden) - Convert.ToDouble(display_value.ToString()));
                    break;
                case InputType.Mul:
                    hidden = Convert.ToString(Convert.ToDouble(hidden) * Convert.ToDouble(display_value.ToString()));
                    break;
                case InputType.Div:
                    hidden = Convert.ToString(Convert.ToDouble(hidden) / Convert.ToDouble(display_value.ToString()));
                    break;
                default:
                    return;
            }
            display_value.Clear();
            status.Reset();
            status.On(Status.Flag.Result_Display);
        }
    

        public void Erase(bool erase_all) {
            if (erase_all || status.Is(Status.Flag.Result_Display)) {
                hidden = "";
                current_operator = InputType.None;
                status.Reset();
            }
            display_value.Clear();
        }
        
        private bool isOperator(InputType input) {
            return operators.Contains(input);
        }
    }
}
