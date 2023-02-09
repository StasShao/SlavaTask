using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPerasonLookCamera : CameraLook//Наследуемся от CameraLook (Слежение за целью без перемещения)
{
    [Header("-------------===========----------------")]
    [Header("Выберите камеру которая будет следить за целью")]
    [SerializeField] private Transform MainCam;
    [Header("-------------===========----------------")]
    [Header("Выберите цель за которой будет следить камера")]
    [SerializeField] private Transform Target;

    void LateUpdate()
    {
        Search(MainCam,Target);//Реализуем метод от класса родителя с переменными из инспектора
    }
}
