using UnityEngine;

namespace ControllSystem//Ѕиблиотека ControllSystem
{
    public class Controller:IControllable// ласс исполн€ющий логику с вход€щими параметрами , реализующий интерфейс IControllable
    {
        public static float MoveValue { get; private set; }//ѕеременные из интерфейса , отвечаюи за отклик по вертикали

        public static float StrafeValue { get; private set; }//ѕеременные из интерфейса , отвечаюи за отклик по горизонтали

        static void SetMoveValue()//ћетод присваивающий переменным из интерфейса Input по горизонатли и вертикали
         {
            MoveValue = Input.GetAxis("Vertical");
            StrafeValue = Input.GetAxis("Horizontal");
         }

        public static void MoveController(Transform movableObject,float force,float moveCoeficient)//Ћогика перегрузка 1
        {
            SetMoveValue();
            movableObject.position = Vector3.Slerp(movableObject.position, new Vector3(movableObject.position.x + StrafeValue * force, 0, movableObject.position.z + MoveValue * force), moveCoeficient * Time.deltaTime);
        }
        public static void MoveController(Rigidbody rb,float force)//Ћогика перегрузка 2
        {
            SetMoveValue();
            rb.AddForce(rb.transform.forward * MoveValue * force,ForceMode.Force);
            rb.AddTorque(rb.transform.up * StrafeValue * force, ForceMode.Force);
        }

    }
}
namespace CameraSys//Ѕиблиотека CameraSys
{
    public class ThirdPersonCameraFollow// ласс исполн€ющий логику с вход€щими параметрами
    {
        public static void CameraLookSmoothFollow(Transform camTransform,Transform target, float speedCoef,Vector3 offSet)//ћетод перегрузка 1 (—глаженное перещение и слежение за целью)
        {
            camTransform.position = Vector3.Slerp(camTransform.position,target.position,speedCoef * Time.deltaTime)+ offSet;
            camTransform.LookAt(target.position);
        }
        public static void CameraLookSmoothFollow(Transform cam,Transform target)//ћетод перегрузка 2 (—лежение за целью)
        {
            cam.LookAt(target);
        }
        public static void CameraLookSmoothFollow(Transform cam,Transform target,Transform pvt,LayerMask planeLayers, float speedCoef, Vector3 offSet)//ћетод перегрузка 3 (—глаженное перещение и слежение за целью с отслеживанием преп€тствий на пути камеры)
        {
            pvt.LookAt(cam);
            cam.LookAt(target.position);
            var dist = Vector3.Distance(pvt.position,cam.position);
            Ray ray = new Ray(pvt.position, pvt.forward * dist);
            Debug.DrawRay(ray.origin,ray.direction * dist,Color.black);
            if(Physics.Raycast(ray,out RaycastHit hit,dist,planeLayers))
            {
                cam.position = hit.point;
            }
            else
            {
                cam.position = Vector3.Slerp(cam.position, target.position, speedCoef * Time.deltaTime) + offSet;
            }
        }
    }
}