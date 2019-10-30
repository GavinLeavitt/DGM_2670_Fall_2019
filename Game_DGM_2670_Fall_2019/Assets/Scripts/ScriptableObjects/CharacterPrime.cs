using UnityEngine;

[CreateAssetMenu]
public class CharacterPrime : CharacterBase
{
    public override void Move()
    {
        location.Set(Input.GetAxis("Vertical") * speed, 0, 0);
        orientation.y = Input.GetAxis("Horizontal") * orientSpeed;
        Controller.transform.Rotate(orientation);
        location = Controller.transform.TransformDirection(location);
        Controller.Move(location * Time.deltaTime);
    }
}
