using UnityEngine;
using ControllSystem;//���������� ���������� ��������� ���� � NameSpace
public class Character : MonoBehaviour// ������� ����� ��������� �� �������� ������������
{
    public virtual void Move(Transform charTransform, float force, float moveCoef) { }//���������� 1
    public virtual void Move(Rigidbody rb, float force) { }//���������� 2

}
public class PhysicCharacter:Character//����������� ����� �� �������� ������ Character � ����������� ���������� ������ ����������� ���������� ����������
{
   
    public override void Move(Rigidbody rb,float force)//���������� ������ Move ���������� 1
    {
        Controller.MoveController(rb,force);//����� �� ControllSystem.Controller - ���������� 1
    }
}
public class TransformCharacter: Character//����������� ����� �� �������� ������ Character � ����������� ���������� ������ ���������� ���������� �� ��������� Transform
{
    public override void Move(Transform charTransform, float force, float moveCoef)//���������� ������ Move ���������� 2
    {
        Controller.MoveController(charTransform,force,moveCoef);//����� �� ControllSystem.Controller - ���������� 2
    }
}
