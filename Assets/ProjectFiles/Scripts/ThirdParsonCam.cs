using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdParsonCam : CameraSmoothLookFollow//Наследуемся от CameraSmoothLookFollow (Сглаженное слежение и следование за целью)
{
    [Header("-----------=========---------------")]
    [Header("Выбери камеру которая будет следить")]
    [Header("за выбранным объектом")]
    [SerializeField] private Transform Camera;
    [Header("-----------=========---------------")]
    [Header("Выбери цель за которой будет следить камера")]
    [SerializeField] private Transform Target;
    [Header("-----------=========---------------")]
    [Header("Установи коэфиент скорости на который будет")]
    [Header("реагировать скорость перемещения камеры")]
    [SerializeField][Range(0.0001f,2.0f)] private float SpeedCoef;
    [Header("-----------=========---------------")]
    [Header("Установи расстояние от цели до камеры")]
    [SerializeField] private Vector3 OffSet;
    private void LateUpdate()
    {
        Search(Camera,Target,SpeedCoef,OffSet);//Реализуем метод с переменными в инспекторе
    }
}
