using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Turnstile
{
    internal class GateClosedState : IGateState
    {
        private Gate _gate;

        public GateClosedState(Gate gate)
        {
            this._gate = gate;
        }

        public void Enter()
        {
            //Do nothing. The user should not be able to open the gate by trying to enter (pushing it)
        }

        public void Pay()
        {
            //The user has tapped the it's metrocard on the turnstile
            _gate.ChangeGateState(new GateProcessingPaymentState(_gate));
        }

        public void PayFailed()
        {
            //Do nothing. The gate should only change it's state to open from the processing state. This might happen after a timeout, and then we get a paymentFailed
        }

        public void PayOk()
        {
            //Do nothing. The gate should only change it's state to open from the processing state. This might happen after a timeout, and then we get a paymentOk

        }
    }
}
