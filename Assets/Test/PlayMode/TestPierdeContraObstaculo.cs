using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;
public class TestPierdeContraObstaculo
{
    string nombreEscena = "PierdeContraObstaculo";

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene(nombreEscena);
    }
    [UnityTest]
    public IEnumerator TestPierdeContraObstaculoWithEnumeratorPasses()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(player);

        int playerOriginalPower = (int)player.GetComponent<ControlJugador>().jugador.poder;

        yield return new WaitForSeconds(1f);

        player.transform.position = new Vector2(-5.4f, -0.1f);

        yield return new WaitForSeconds(1f);

        Assert.AreNotEqual(player.GetComponent<ControlJugador>().jugador.poder, playerOriginalPower);
    }
    public void Teardown()
    {
        EditorSceneManager.UnloadSceneAsync(nombreEscena);
    }
}
