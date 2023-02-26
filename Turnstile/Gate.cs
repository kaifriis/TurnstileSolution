namespace Turnstile;

public class Gate
{
    IGateState _state;

    public Gate()
    {
        //This should be DI, here it instansiated for simplisity
        _state = new GateClosedState(this);
    }

    public void Enter()
    {
        _state.Enter();
    }

    public void Pay()
    {
        _state.Pay();
    }

    public void PayOk()
    {
        _state.PayOk();
    }

    public void PayFailed()
    {
        _state.PayFailed();
    }

    public void ChangeGateState(IGateState state)
    {
        _state = state;
    }
}
