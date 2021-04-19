using System;
using UnityEngine;

namespace Character
{

    public abstract class Character : MonoBehaviour
    {
        protected ICharacterInput CharacterInput;

        [SerializeField] protected float Speed;
        [SerializeField] protected float Gravity;
        protected Animator Animator;
        protected CharacterState CharacterState = CharacterState.Idle;
        public virtual void Awake()
        {
            Animator = GetComponentInChildren<Animator>();
        }

        public virtual void Start()
        {
            
        }

        // public virtual void Move(float speed)
        // {
        //     if (CharacterInput.PointMove == Vector3.zero)
        //     {
        //         CharacterState = CharacterState.Idle;
        //     }
        //     else
        //     {
        //         CharacterState = CharacterState.Run;
        //     }
        //     Animator.SetFloat("Speed", speed);
        // }

        // public virtual void Update()
        // {
        //     
        // }
    }
}
