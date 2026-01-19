


using UnityEngine;

public class EntityState
{
    // The member is accessible inside the same class and
    // in any class that inherits from it (child / subclass).
    // But not from other scripts.
    protected StateMachine stateMachine;

    protected string stateName;

    // Constructor
    public EntityState(StateMachine stateMachine, string stateName)
    {
        this.stateMachine = stateMachine;
        this.stateName = stateName;
    }

    // virtual means this method provides a default implementation,
    // but child classes are allowed to OVERRIDE it and provide
    // their own specific behavior.
    public virtual void Enter() 
    {
        // Called ONCE when this state becomes the active state.
        // Use this to initialize state-specific logic
        // (start animations, reset timers, set variables).

        Debug.Log("Entering state: " + stateName);
    }

    public virtual void Update()
    {
        // Called EVERY FRAME while this state is active.
        // Contains the continuous logic of the state
        // and checks for transitions to other states.
        //
        // We run the state Update from the Player's Update()
        // because Unity only calls Update() on MonoBehaviour classes.
        // The Player has access to all Unity-specific functionality,
        // and it forwards the Update call to the active state.

        Debug.Log("Updating state: " + stateName);

    }

    public virtual void Exit()
    {
        // Called ONCE when this state is about to be exited.
        // Use this to clean up before switching to another state
        // (stop animations, reset values, remove listeners).

        Debug.Log("Exiting state: " + stateName);
    }

}
