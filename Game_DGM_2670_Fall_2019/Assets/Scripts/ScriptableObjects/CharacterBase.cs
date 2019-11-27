using UnityEngine;

public abstract class CharacterBase : ScriptableObject
{
	public float moveSpeed = 3f;
	public float gravity = -3f;
	public float jumpSpeed = 2f;
	public CharacterController controller { get; set; }
	protected Vector3 location;
	protected Vector3 orientation;

	public virtual void Move()
	{
		location.x = (Input.GetAxis("Horizontal")*moveSpeed);
		location.y += gravity*Time.deltaTime;
		controller.Move(location*Time.deltaTime);
	}

	public virtual void Jump()
	{
		if (Input.GetButton("Jump"))
		{
			location.y = jumpSpeed;
		}
	}
}