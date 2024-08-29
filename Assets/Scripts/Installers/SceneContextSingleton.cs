using UnityEngine;
using Zenject;

public class SceneContextSingleton : MonoBehaviour//этот скрипт и InjectObject нужны для объектов, которые спавнятся, чтобы все заинжектить
{
    public static SceneContext Instance;

    private void Awake() => Instance = GetComponent<SceneContext>();
}