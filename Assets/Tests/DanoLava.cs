using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using NUnit.Framework;
using System.Collections;

public class DanoLava {

    [Test]
    public void DanoLavaSimplePasses() {
        // Use the Assert class to test conditions.
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator TemLava() {
        SceneManager.LoadScene("Jogo");
        yield return null;
        GameObject player = GameObject.Find("Alien");
        bool enconstalava = false;
        yield return null;
        Assert.IsTrue(enconstalava);
    }
}
