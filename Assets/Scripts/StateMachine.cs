public class StateMachine
{
    // Holds a reference to the currently active state.
    // At any given time, only ONE state should be active.
    // Other classes can READ the current state,
    // but only the StateMachine itself is allowed to change it.
    public EntityState currentState { get; private set; }

    // Sets the initial state of the state machine.
    // This should be called ONCE when the entity is created.
    // It assigns the starting state and calls Enter()
    // to initialize that state's behavior.
    public void Initialize(EntityState startState)
    {
        currentState = startState;
        currentState.Enter();
    }

    // Changes the current state to a new state.
    // This method ensures a proper state transition by:
    // 1) Exiting the current state (cleanup)
    // 2) Switching to the new state
    // 3) Entering the new state (setup)
    public void ChangeState(EntityState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}

