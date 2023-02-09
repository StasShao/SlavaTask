using UnityEngine;

namespace ControllSystem//���������� ControllSystem
{
    public class Controller:IControllable//����� ����������� ������ � ��������� ����������� , ����������� ��������� IControllable
    {
        public static float MoveValue { get; private set; }//���������� �� ���������� , �������� �� ������ �� ���������

        public static float StrafeValue { get; private set; }//���������� �� ���������� , �������� �� ������ �� �����������

        static void SetMoveValue()//����� ������������� ���������� �� ���������� Input �� ����������� � ���������
         {
            MoveValue = Input.GetAxis("Vertical");
            StrafeValue = Input.GetAxis("Horizontal");
         }

        public static void MoveController(Transform movableObject,float force,float moveCoeficient)//������ ���������� 1
        {
            SetMoveValue();
            movableObject.position = Vector3.Slerp(movableObject.position, new Vector3(movableObject.position.x + StrafeValue * force, 0, movableObject.position.z + MoveValue * force), moveCoeficient * Time.deltaTime);
        }
        public static void MoveController(Rigidbody rb,float force)//������ ���������� 2
        {
            SetMoveValue();
            rb.AddForce(rb.transform.forward * MoveValue * force,ForceMode.Force);
            rb.AddTorque(rb.transform.up * StrafeValue * force, ForceMode.Force);
        }

    }
}
namespace CameraSys//���������� CameraSys
{
    public class ThirdPersonCameraFollow//����� ����������� ������ � ��������� �����������
    {
        public static void CameraLookSmoothFollow(Transform camTransform,Transform target, float speedCoef,Vector3 offSet)//����� ���������� 1 (���������� ��������� � �������� �� �����)
        {
            camTransform.position = Vector3.Slerp(camTransform.position,target.position,speedCoef * Time.deltaTime)+ offSet;
            camTransform.LookAt(target.position);
        }
        public static void CameraLookSmoothFollow(Transform cam,Transform target)//����� ���������� 2 (�������� �� �����)
        {
            cam.LookAt(target);
        }
        public static void CameraLookSmoothFollow(Transform cam,Transform target,Transform pvt,LayerMask planeLayers, float speedCoef, Vector3 offSet)//����� ���������� 3 (���������� ��������� � �������� �� ����� � ������������� ����������� �� ���� ������)
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