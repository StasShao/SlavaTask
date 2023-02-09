using UnityEngine;

public class Sphere : PhysicCharacter//����� Sphere ����������� �� PhysicCharacter
{
    [Header("-----------=========---------------")]
    [Header("������ Rigidbody �������� , ������������ �������")]
    [SerializeField] private Rigidbody Rb;
    [Header("-----------=========---------------")]
    [Header("�������� ������ ������� ����� ����������� � �������")]
    [SerializeField] private float Force;
    private void FixedUpdate()
    {
        Move(Rb,Force);//�������� ���������� ������������ ������ ��������������� ������� ������ (���������� �����������)
    }

}
