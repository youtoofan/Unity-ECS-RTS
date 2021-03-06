﻿using System;
using Unity.Entities;
using Unity.Mathematics;

[Serializable]
public struct PlayerInput : IComponentData {

    public BlittableBool LeftClick;
    public BlittableBool RightClick; 
}

public class PlayerInputComponent : ComponentDataWrapper<PlayerInput> { }
