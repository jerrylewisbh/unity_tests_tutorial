using UnityEngine;

public partial class Spacecraft
{
    public class PlayerInput : IInput
    {
        public float Vertical => Input.GetAxis("Vertical");
    }
}