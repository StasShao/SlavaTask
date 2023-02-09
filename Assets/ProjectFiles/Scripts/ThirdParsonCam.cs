using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdParsonCam : CameraSmoothLookFollow//����������� �� CameraSmoothLookFollow (���������� �������� � ���������� �� �����)
{
    [Header("-----------=========---------------")]
    [Header("������ ������ ������� ����� �������")]
    [Header("�� ��������� ��������")]
    [SerializeField] private Transform Camera;
    [Header("-----------=========---------------")]
    [Header("������ ���� �� ������� ����� ������� ������")]
    [SerializeField] private Transform Target;
    [Header("-----------=========---------------")]
    [Header("�������� �������� �������� �� ������� �����")]
    [Header("����������� �������� ����������� ������")]
    [SerializeField][Range(0.0001f,2.0f)] private float SpeedCoef;
    [Header("-----------=========---------------")]
    [Header("�������� ���������� �� ���� �� ������")]
    [SerializeField] private Vector3 OffSet;
    private void LateUpdate()
    {
        Search(Camera,Target,SpeedCoef,OffSet);//��������� ����� � ����������� � ����������
    }
}
