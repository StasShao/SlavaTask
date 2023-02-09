using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerasonLookCamera : CameraLook//����������� �� CameraLook (�������� �� ����� ��� �����������)
{
    [Header("-------------===========----------------")]
    [Header("�������� ������ ������� ����� ������� �� �����")]
    [SerializeField] private Transform MainCam;
    [Header("-------------===========----------------")]
    [Header("�������� ���� �� ������� ����� ������� ������")]
    [SerializeField] private Transform Target;

    void LateUpdate()
    {
        Search(MainCam,Target);//��������� ����� �� ������ �������� � ����������� �� ����������
    }
}
