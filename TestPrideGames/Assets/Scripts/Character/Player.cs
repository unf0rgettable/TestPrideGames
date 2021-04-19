using System;
using UnityEngine;

namespace Character
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    public class Player : Character
    {
        private CharacterController CharacterCont;

        private Vector3 _previousPosition;
        private float _moveLength;
        private float _turn;
        public override void Awake()
        {
            base.Awake();
            CharacterCont = GetComponent<CharacterController>();
            CharacterInput = GetComponent<PlayerInput>();
        }

        private void Start()
        {

        }

        public void Update()
        {
            _previousPosition = transform.position;
            if (CharacterInput.PointMove != Vector3.zero)
            {
                CharacterCont.Move((new Vector3(0,Gravity,0) + CharacterInput.PointMove) * Speed);
                float targetAngle = Mathf.Atan2(CharacterInput.PointMove.x, CharacterInput.PointMove.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turn, 0.05f);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
            _moveLength = Vector3.Distance(_previousPosition, transform.position);
            Animator.SetFloat("Speed", _moveLength);
        }
    }
}