using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveController : MonoBehaviour
{
    private CharacterController controller;
    public ScriptableObject mover;
    private IMove iMover;
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        iMover = mover as IMove;
    }

    public void ChangeMover(ScriptableObject newMover)
    {
        iMover = newMover as IMove;
    }

    private void Update()
    {
        iMover.Move(controller);
    }
}
