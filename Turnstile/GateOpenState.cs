namespace Turnstile;

public class GateOpenState : IGateState
{
    private readonly Gate _gate;

    public GateOpenState(Gate gate)
    {
        _gate = gate;
    }
    public void Enter()
    {
        //Let the user through.
        _gate.ChangeGateState(new GateClosedState(_gate));
    }

    public void Pay()
    {
        //Do nothing.No need  to test here. The gate is open so we do nothing if the user tries to pay one more time.
        //If you would like to make the Gate immutable, you  would return a new GateOpenState instance to replace the curent gate object.
    }

    public void PayFailed()
    {
        //Do nothing. We know that gate is open and it doesn't matter if a new payment processing fails
    }

    public void PayOk()
    {
        //Do nothing. We know that gate is open and it doesn't matter if the user tries to pay again. We should not charge her traveling card.
    }
}
