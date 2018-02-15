using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCore {
    public class Status {
        [Flags]
        public enum Flag {
            Dotted = 1,
            Operator_Pressed = 1 << 1,
            Operator_Just_Pressed = 1 << 2,
            Result_Display = 1 << 3
        }

        private Flag flag = 0;

        public Status() {

        }

        public void On(Flag flag) {
            this.flag |= flag;
        }

        public void Off(Flag flag) {
            this.flag &= ~flag;
        }

        public bool Is(Flag flag) {
            return (this.flag & flag) != 0;
        }

        public bool IsNot(Flag flag) {
            return (this.flag & flag) == 0;
        }

        public void ResetExcept(Flag flag) {
            this.flag &= flag;
        }

        public void Reset() {
            flag = 0;
        }
    }
}
