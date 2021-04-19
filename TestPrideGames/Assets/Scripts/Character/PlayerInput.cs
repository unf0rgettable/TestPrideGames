using UnityEngine;

namespace Character
{
    public class PlayerInput : MonoBehaviour, ICharacterInput
    {
        public Vector3 PointMove
        {
            get
            {
                return new Vector3(Input.GetAxisRaw("Horizontal"), 0,Input.GetAxisRaw("Vertical")).normalized;
            }
        }
    }
}