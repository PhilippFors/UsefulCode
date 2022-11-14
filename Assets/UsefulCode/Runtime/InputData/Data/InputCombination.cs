﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.Input.Data
{
    [System.Serializable]
    public class InputCombination
    {
        public InputAction Action => property.action;
        public Inputs inputs;

        [SerializeField] private InputActionProperty property;
    }
}