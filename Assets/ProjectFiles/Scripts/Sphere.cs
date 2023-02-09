using UnityEngine;

public class Sphere : PhysicCharacter//Класс Sphere наследуемый от PhysicCharacter
{
    [Header("-----------=========---------------")]
    [Header("Выбери Rigidbody главного , управляемого объекта")]
    [SerializeField] private Rigidbody Rb;
    [Header("-----------=========---------------")]
    [Header("Установи усилие которое будет прилагаться к объекту")]
    [SerializeField] private float Force;
    private void FixedUpdate()
    {
        Move(Rb,Force);//Выбираем перегрузку наследуемого класса соответствующую данному классу (физическое перемещение)
    }

}
