using UnityEngine;

public class Cub : TransformCharacter//Класс куб наследуемый от TransformCharacter
{
    [Header("-----------=========---------------")]
    [Header("Выбери Transform главного , управляемого объекта")]
    [SerializeField] private Transform Chartransform;
    [Header("-----------=========---------------")]
    [Header("Установи на сколько метров за каждый кадр")]
    [Header("будет перемещаться объект")]
    [SerializeField] private float Force;
    [Header("-----------=========---------------")]
    [Header("Установи коэфициент скорости перемещения")]
    [SerializeField] private float MoveCoef;
    private void Update()
    {
        Move(Chartransform,Force,MoveCoef);//Выбираем перегрузку наследуемого класса соответствующую данному классу (Не физическое перемещение)
    }
}
