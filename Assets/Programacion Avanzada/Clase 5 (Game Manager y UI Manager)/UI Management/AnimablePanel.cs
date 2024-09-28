using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Management
{
    // Este script no es necesario que lo aprendan ni estudien, pero lo dejaré por si quieren
    // que sus paneles tengan una animación de entrada y de salida.
    public class AnimablePanel : Panel
    {
        // Este sera el identificador con que el detectaremos si el objeto se tiene que abrir o cerrar.
        [Header("Animation Settings")]
        [SerializeField] private float m_animationTime = 0.25f;

        [Header("Opacity Animation")]
        [SerializeField] private CanvasGroup m_canvasGroup;

        [Header("Rect Animation")]
        [SerializeField] private RectTransform m_rectTransform;
        [SerializeField] private Vector2 m_enabledPosition;
        [SerializeField] private Vector2 m_disabledPosition = Vector2.down * 32;

        private Coroutine m_currentAnimation;

        // Esta funcion se ejecuta cuando el componente se crea en el inspector.
        private void Reset()
        {
            TryGetComponent(out m_canvasGroup);
            TryGetComponent(out m_rectTransform);
        }

        // Acá hago un override de la función Open y ejecuto la coroutina siempre.
        // Acá si llamaré a base.Open, ya que quiero que si se ejecute lo del padre.
        public override void Open()
        {
            base.Open();

            if (m_currentAnimation != null) StopCoroutine(m_currentAnimation);
            m_currentAnimation = StartCoroutine(InOut(true));
        }

        // En cambio aca no llamaré a base.Close, ya que eso desactivaria el objeto instantaneamente
        // cosa que no quiero que ocurra.
        public override void Close()
        {
            if (!gameObject.activeSelf) return;

            if (m_currentAnimation != null) StopCoroutine(m_currentAnimation);
            m_currentAnimation = StartCoroutine(InOut(false));
        }

        // Acá haré un override de la función Set para establecer los valores por defecto del 
        // RectTransform y CanvasGroup.
        public override void Set(bool active)
        {
            base.Set(active);
            m_rectTransform.localPosition = active ? m_enabledPosition : m_disabledPosition;
            m_canvasGroup.alpha = active ? 1 : 0;
        }

        // Coroutines
        private IEnumerator InOut(bool active)
        {
            // Aca establecere que el valor inicial de la animacion sera el valor actual del canvasGroup.
            float alphaA = m_canvasGroup.alpha;

            // En cambio aca hare que el valor final sea 1 si active es true o 0 si es false.
            float alphaB = active ? 1 : 0;

            // Aca establecere que la posicion inicial sera el valor actual del rectTransform
            Vector2 positionA = m_rectTransform.anchoredPosition;

            // Y aca establecere que la posicion final sera enabledPosition o disabledPosition dependiendo
            // de la variable active.
            Vector2 positionB = active ? m_enabledPosition : m_disabledPosition;

            // Aca comenzare a ejecutar la animacion por el tiempo que le indique desde la variable animationTime.
            for (float i = 0; i < m_animationTime; i += Time.deltaTime)
            {
                float t = i / m_animationTime;

                // Aca hago el lerp desde el valor inicial hasta el valor final utilizando el valor de la interpolacion, t.
                m_rectTransform.anchoredPosition = Vector2.Lerp(positionA, positionB, t);
                m_canvasGroup.alpha = Mathf.Lerp(alphaA, alphaB, t);
                yield return null;
            }

            // Aca establezco el valor final del canvasGroup y del rectTransform para evitar que quede en un valor cercano al final.
            // Por ejemplo, alpha = 0.99996
            m_rectTransform.anchoredPosition = positionB;
            m_canvasGroup.alpha = alphaB;

            // Y finalmente, si estoy cerrando el panel, y la animacion termino,
            // desactivare el objeto.
            if (!active) gameObject.SetActive(false);
        }
    }
}