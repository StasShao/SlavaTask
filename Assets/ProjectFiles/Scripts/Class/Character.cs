using UnityEngine;
using ControllSystem;//Подключаем библиотеку созданную нами в NameSpace
public class Character : MonoBehaviour// Базовый класс персонажа от которого наследование
{
    public virtual void Move(Transform charTransform, float force, float moveCoef) { }//Перегрузка 1
    public virtual void Move(Rigidbody rb, float force) { }//Перегрузка 2

}
public class PhysicCharacter:Character//Наследуемый класс от базового класса Character с реализацией перегрузки метода физического управления персонажем
{
   
    public override void Move(Rigidbody rb,float force)//реализация метода Move Перегрузки 1
    {
        Controller.MoveController(rb,force);//Метод из ControllSystem.Controller - перегрузка 1
    }
}
public class TransformCharacter: Character//Наследуемый класс от базового класса Character с реализацией перегрузки метода управления персонажем по средствам Transform
{
    public override void Move(Transform charTransform, float force, float moveCoef)//реализация метода Move Перегрузки 2
    {
        Controller.MoveController(charTransform,force,moveCoef);//Метод из ControllSystem.Controller - перегрузка 2
    }
}
