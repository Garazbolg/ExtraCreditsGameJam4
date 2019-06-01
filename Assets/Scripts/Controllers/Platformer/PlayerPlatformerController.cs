using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject
{
	public Data.PlayerInputData inputData;
	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	public bool FlipX = false;
	private bool flippedX = false;
	
	private Animator animator;
	Vector2 move;

	// Use this for initialization
	void Awake()
	{
		animator = GetComponent<Animator>();
	}

	protected override void ComputeVelocity()
	{
		move = Vector2.zero;

		move.x = inputData.GetAxis(Data.PlayerInputData.InputAxis.X);

		if (inputData.GetButtonDown(Data.PlayerInputData.InputButton.Jump) && grounded)
		{
			velocity.y = jumpTakeOffSpeed;
		}
		else if (inputData.GetButtonUp(Data.PlayerInputData.InputButton.Jump))
		{
			if (velocity.y > 0)
			{
				velocity.y = velocity.y * 0.5f;
			}
		}

		bool flipSprite = (flippedX ? (move.x > 0.01f) : (move.x < 0.01f));
		if (flipSprite)
		{
			transform.Rotate(0, 180, 0);
		}


		if (animator)
		{
			animator.SetBool("grounded", grounded);
			animator.SetFloat("velocityX", Mathf.Abs(velocity.x) / maxSpeed);
		}

		targetVelocity = move * maxSpeed;
	}
}