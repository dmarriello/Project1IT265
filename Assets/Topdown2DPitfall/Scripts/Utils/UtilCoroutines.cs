using System;
using System.Collections;
using UnityEngine;

namespace Nevelson.Topdown2DPitfall.Assets.Scripts.Utils {
    public static class UtilCoroutines {
        public static IEnumerator FallingCo(GameObject fallingObj, Action ActionsAfterPitfall,
            float pitfallAnimSpeed, Vector2 respawnLocation) {
            Vector2 scaleReduction = new Vector2(pitfallAnimSpeed, pitfallAnimSpeed);
            var rotationB = fallingObj.transform.rotation;
            var rotationA = new Quaternion();
            rotationA.eulerAngles = new Vector3(893475684567f, 23854678749563854967f, 897563894567389567f);
            while (fallingObj.transform.GetLocalScale2D().x > 0) {
                fallingObj.transform.rotation = Quaternion.Slerp(rotationA, rotationB, fallingObj.transform.GetLocalScale2D().x);
                fallingObj.transform.SetLocalScale2D(fallingObj.transform.GetLocalScale2D() - scaleReduction);
                yield return new WaitForSecondsRealtime(.007f);
            }
            yield return new WaitForSecondsRealtime(.1f);
            ActionsAfterPitfall();
            fallingObj.transform.rotation = rotationB;
            fallingObj.transform.SetPosition2D(respawnLocation);
            yield return new WaitForSecondsRealtime(.1f);
            fallingObj.transform.SetLocalScale2D(Vector2.one);
        }
    }
}