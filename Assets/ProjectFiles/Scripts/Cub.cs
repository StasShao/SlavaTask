using UnityEngine;

public class Cub : TransformCharacter//����� ��� ����������� �� TransformCharacter
{
    [Header("-----------=========---------------")]
    [Header("������ Transform �������� , ������������ �������")]
    [SerializeField] private Transform Chartransform;
    [Header("-----------=========---------------")]
    [Header("�������� �� ������� ������ �� ������ ����")]
    [Header("����� ������������ ������")]
    [SerializeField] private float Force;
    [Header("-----------=========---------------")]
    [Header("�������� ���������� �������� �����������")]
    [SerializeField] private float MoveCoef;
    private void Update()
    {
        Move(Chartransform,Force,MoveCoef);//�������� ���������� ������������ ������ ��������������� ������� ������ (�� ���������� �����������)
    }
}
