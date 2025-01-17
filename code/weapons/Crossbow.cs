﻿using Sandbox;

[Library( "xbow", Title = "Crossbow", Spawnable = true )]
public class Crossbow : Weapon
{
	static SoundEvent Attack = new SoundEvent( "weapons/rust_crossbow/sounds/crossbow-attack-1.vsnd" );
	public override float Damage => 100;
	public override int RPM => 250;
	public override float ReloadTime => 3;
	public override float Spread => 0f;
	public override string ShootShound => "Crossbow.Attack";
	public override string WorldModelPath => "weapons/rust_crossbow/rust_crossbow.vmdl";
	public override string ViewModelPath => "weapons/rust_crossbow/v_rust_crossbow.vmdl";
	public override string Projectile => "xbow_bolt";
	public override string Brass => null;
	public override string MuzzleFlash => null;
	public override float ProjectileSpeed => 5000;
	public override CrosshairType CrosshairType => CrosshairType.Dot;
	public override AmmoType AmmoType => AmmoType.Bolt;
	public override bool CanAim => true;
	public override float HeadshotMultiplier => 1.75f;
	public override string Name => "Crossbow";

	[Event.Tick]
	void OnTick()
	{
		ViewModelEntity?.SetAnimBool( "loaded", AmmoClip != 0 );
	}
}

[Library( "xbow_bolt" )]
public class CrossbowBolt : Projectile
{
	// Temporary, projectiles need some more work
	public override bool DestroyOnPlayerImpact => true;
	public override bool DestroyOnWorldImpact => false;
	public override float Force => 0.001f;

	public override bool StickInWalls => true;

	public override string ModelPath => "models/arrow_wooden/arrow_wooden.vmdl";
}
