namespace Turnstile;

public interface IGateState
{
    void Enter();
    void Pay();
    void PayOk();
    void PayFailed();
}
