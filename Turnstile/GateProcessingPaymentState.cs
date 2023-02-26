namespace Turnstile
{
    internal class GateProcessingPaymentState : IGateState
    {
        private readonly Gate _gate;
        public GateProcessingPaymentState(Gate gate)
        {
            _gate = gate;
        }
        public void Enter()
        {
            //Do nothing. The user should not be able to open the gate by trying to enter (pushing it), the payment is still processing
        }

        public void Pay()
        {
            //Do nothing. We are still processing the previous payment
        }

        public void PayFailed()
        {
            //Flash a some warning. 
            _gate.ChangeGateState(new GateClosedState(_gate));
        }

        public void PayOk()
        {
            _gate.ChangeGateState(new GateOpenState(_gate));
        }
    }
}
