using UnityEngine;
using CameraSys;
public class CameraFollow : MonoBehaviour//Класс родитель содержащий в себе перегрузки методов
{
    public virtual void Search(Transform cam, Transform target, float speedCoef, Vector3 offSet) { }//Перегрузка 1
    public virtual void Search(Transform cam,Transform target) { }
    public virtual void Search(Transform cam, Transform target,Transform pvt,LayerMask planeLayers, float speedCoef, Vector3 offSet) { }


}
public class CameraSmoothLookFollow:CameraFollow//Класс наследник реализующий перегрузки методов

{
    public override void Search(Transform cam, Transform target, float speedCoef, Vector3 offSet)//Реализация перегрузки 1 логикой из библиотеки CameraSys
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target, speedCoef, offSet);//Логика из библиотеки
    }
}
public class CameraLook: CameraFollow//Класс наследник реализующий перегрузки методов
{
    public override void Search(Transform cam, Transform target)//Реализация перегрузки 2 логикой из библиотеки CameraSys
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target);//Логика из библиотеки
    }
}
public class CameraSmoothLookFollowWithPlaneCheck: CameraFollow
{
    public override void Search(Transform cam, Transform target,Transform pvt, LayerMask planeLayers, float speedCoef, Vector3 offSet)
    {
        ThirdPersonCameraFollow.CameraLookSmoothFollow(cam, target,pvt, planeLayers, speedCoef, offSet);
    }
}
