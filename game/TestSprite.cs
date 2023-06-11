using Godot;
using System;

public class TestSprite : Sprite
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private float dt;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		dt += delta;
		
		Position = new Vector2((float)Math.Sin(dt) * 100, (float)Math.Cos(dt) * 100);
		//Position += new Vector2(1, 1);
	}
}
