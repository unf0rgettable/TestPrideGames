using System;
using UnityEngine;

namespace Character
{
    public class AIInput : MonoBehaviour, ICharacterInput
    {
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        public Vector3 PointMove
        {
            get
            {
                if (Input.GetMouseButton(0))
                {
                    RaycastHit hit;
                    Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 1000))
                    {
                        return hit.point;
                    }
                }
                
                return Vector3.zero;
            }
        }
    }
}