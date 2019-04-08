using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atalanta.Services
{
    public interface ISceneLoader
    {
        void LoadScene(string sceneName);
    }
}