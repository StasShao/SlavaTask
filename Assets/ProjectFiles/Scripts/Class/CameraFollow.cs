using UnityEngine;
using CameraSys;
public class CameraFollow : MonoBehaviour//����� �������� ���������� � ���� ���������� �������
{
    public virtual void Search(Transform cam, Transform target, float speedCoef, Vector3 offSet) { }//���������� 1
    public virtual void Search(Transform cam,Transform target) { }
    public virtual void Search(Transform cam, Transform target,Transform pvt,LayerMask planeLayers, float speedCoef, Vector3 offSet) { }


}
public class CameraSmoothLookFollow:CameraFollow//����� ��������� ����������� ���������� �������

{
    public override void Search(Transform cam, Transform target, float speedCoef, Vector3 offSet)//���������� ���������� 1 ������� �� ���������� CameraSys
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target, speedCoef, offSet);//������ �� ����������
    }
}
public class CameraLook: CameraFollow//����� ��������� ����������� ���������� �������
{
    public override void Search(Transform cam, Transform target)//���������� ���������� 2 ������� �� ���������� CameraSys
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target);//������ �� ����������
    }
}
public class CameraSmoothLookFollowWithPlaneCheck: CameraFollow
{
    public override void Search(Transform cam, Transform target,Transform pvt, LayerMask planeLayers, float speedCoef, Vector3 offSet)
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target,pvt, planeLayers, speedCoef, offSet);
    }
}
