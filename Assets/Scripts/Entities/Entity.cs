using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected Health healthManager;
    [SerializeField] protected CharacterController characterController;
    [SerializeField] protected float speed;

    public bool IsAlive => healthManager.IsAlive;

}
