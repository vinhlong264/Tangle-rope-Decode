using System;
using System.Collections;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DG.Tweening
{
    public delegate T DOGetter<out T>();
    public delegate void DOSetter<in T>(T newValue);
    public delegate void TweenCallback();
    public delegate void TweenCallback<in T>(T value);

    public enum Ease
    {
        Unset,
        Linear,
        InSine,
        OutSine,
        InOutSine,
        InQuad,
        OutQuad,
        InOutQuad,
        InOutCirc,
        Flash,
        INTERNAL_Custom
    }

    public enum RotateMode
    {
        Fast,
        FastBeyond360,
        WorldAxisAdd,
        LocalAxisAdd
    }

    public enum LoopType
    {
        Restart,
        Yoyo,
        Incremental
    }

    public enum UpdateType
    {
        Normal,
        Late,
        Fixed,
        Manual
    }

    public enum PathType
    {
        Linear,
        CatmullRom,
        CubicBezier
    }

    public enum PathMode
    {
        Ignore,
        Full3D,
        TopDown2D,
        Sidescroller2D
    }

    public enum AxisConstraint
    {
        None,
        X,
        Y,
        Z,
        W
    }

    public enum ScrambleMode
    {
        None,
        All,
        Uppercase,
        Lowercase,
        Numerals,
        Custom
    }

    public enum LogBehaviour
    {
        Default,
        Verbose,
        ErrorsOnly
    }

    public class Tween : CustomYieldInstruction
    {
        public bool active = true;
        public bool playedOnce;
        public bool isBackwards;
        public bool autoKill = true;
        public int completedLoops;
        public int loops = 1;
        public float position;
        public float duration;
        public object id;
        public object target;
        public TweenCallback onComplete;
        public TweenCallback onKill;
        public TweenCallback onPause;
        public TweenCallback onPlay;
        public TweenCallback onRewind;
        public TweenCallback onStart;
        public TweenCallback onStepComplete;
        public TweenCallback onUpdate;
        public TweenCallback<int> onWaypointChange;

        public override bool keepWaiting => false;

        public virtual Tween Play()
        {
            return this;
        }

        public virtual Tween Pause()
        {
            return this;
        }

        public virtual Tween Restart(bool includeDelay = true)
        {
            return this;
        }

        public virtual Tween Rewind(bool includeDelay = true)
        {
            return this;
        }

        public virtual Tween Complete(bool withCallbacks = false)
        {
            return this;
        }

        public virtual void Kill(bool complete = false)
        {
        }

        public virtual Tween Goto(float to, bool andPlay = false)
        {
            return this;
        }

        public virtual bool IsActive()
        {
            return active;
        }

        public virtual bool IsPlaying()
        {
            return false;
        }

        public virtual bool IsComplete()
        {
            return false;
        }

        public virtual Tween SetAutoKill(bool value)
        {
            autoKill = value;
            return this;
        }

        public virtual Tween SetDelay(float delay)
        {
            return this;
        }

        public virtual Tween SetEase(Ease ease)
        {
            return this;
        }

        public virtual Tween SetEase(AnimationCurve curve)
        {
            return this;
        }

        public virtual Tween SetId(object newId)
        {
            id = newId;
            return this;
        }

        public virtual Tween SetLink(GameObject gameObject)
        {
            target = gameObject;
            return this;
        }

        public virtual Tween SetLoops(int newLoops, LoopType loopType = LoopType.Restart)
        {
            loops = newLoops;
            return this;
        }

        public virtual Tween SetRecyclable(bool recyclable)
        {
            return this;
        }

        public virtual Tween SetTarget(object newTarget)
        {
            target = newTarget;
            return this;
        }

        public virtual Tween SetUpdate(bool isIndependentUpdate)
        {
            return this;
        }

        public virtual Tween SetUpdate(UpdateType updateType, bool isIndependentUpdate = false)
        {
            return this;
        }

        public virtual Tween OnComplete(TweenCallback action)
        {
            onComplete = action;
            return this;
        }

        public virtual Tween OnKill(TweenCallback action)
        {
            onKill = action;
            return this;
        }

        public virtual Tween OnPause(TweenCallback action)
        {
            onPause = action;
            return this;
        }

        public virtual Tween OnPlay(TweenCallback action)
        {
            onPlay = action;
            return this;
        }

        public virtual Tween OnRewind(TweenCallback action)
        {
            onRewind = action;
            return this;
        }

        public virtual Tween OnStart(TweenCallback action)
        {
            onStart = action;
            return this;
        }

        public virtual Tween OnStepComplete(TweenCallback action)
        {
            onStepComplete = action;
            return this;
        }

        public virtual Tween OnUpdate(TweenCallback action)
        {
            onUpdate = action;
            return this;
        }

        public virtual Tween OnWaypointChange(TweenCallback<int> action)
        {
            onWaypointChange = action;
            return this;
        }

        public virtual Tween From(bool isRelative = false)
        {
            return this;
        }

        public virtual Tween ForceInit()
        {
            return this;
        }

        public virtual YieldInstruction WaitForCompletion()
        {
            return null;
        }

        public virtual YieldInstruction WaitForElapsedLoops(int elapsedLoops)
        {
            return null;
        }

        public virtual YieldInstruction WaitForKill()
        {
            return null;
        }

        public virtual YieldInstruction WaitForPosition(float waitPosition)
        {
            return null;
        }

        public virtual YieldInstruction WaitForRewind()
        {
            return null;
        }

        public virtual YieldInstruction WaitForStart()
        {
            return null;
        }
    }

    public class Tweener : Tween
    {
    }

    public class Sequence : Tween
    {
        public Sequence Append(Tween tween)
        {
            return this;
        }

        public Sequence AppendCallback(TweenCallback callback)
        {
            return this;
        }

        public Sequence AppendInterval(float interval)
        {
            return this;
        }

        public Sequence Insert(float atPosition, Tween tween)
        {
            return this;
        }

        public Sequence InsertCallback(float atPosition, TweenCallback callback)
        {
            return this;
        }

        public Sequence Join(Tween tween)
        {
            return this;
        }

        public Sequence Prepend(Tween tween)
        {
            return this;
        }

        public Sequence PrependCallback(TweenCallback callback)
        {
            return this;
        }

        public Sequence PrependInterval(float interval)
        {
            return this;
        }
    }

    public static class DOTween
    {
        public static LogBehaviour logBehaviour;
        public static float defaultEasePeriod;

        public static void Init(bool recycleAllByDefault = false, bool useSafeMode = true, LogBehaviour behaviour = LogBehaviour.ErrorsOnly)
        {
            logBehaviour = behaviour;
        }

        public static void Clear(bool destroy = false)
        {
        }

        public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
        {
        }

        public static Sequence Sequence()
        {
            return new Sequence();
        }

        public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration)
        {
            return new TweenerCore<int, int, NoOptions>();
        }

        public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration)
        {
            return new TweenerCore<Vector2, Vector2, VectorOptions>();
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration)
        {
            return new TweenerCore<Vector3, Vector3, VectorOptions>();
        }

        public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration)
        {
            return new TweenerCore<Color, Color, ColorOptions>();
        }

        public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration)
        {
            return new TweenerCore<string, string, StringOptions>();
        }

        public static int Kill(object targetOrId, bool complete = false)
        {
            return 0;
        }

        public static int Pause(object targetOrId)
        {
            return 0;
        }

        public static int Play(object targetOrId)
        {
            return 0;
        }

        public static int Complete(object targetOrId, bool withCallbacks = false)
        {
            return 0;
        }

        public static int Restart(object targetOrId, bool includeDelay = true, float changeDelayTo = -1f)
        {
            return 0;
        }
    }

    public class TweenParams
    {
        public TweenParams SetEase(Ease ease)
        {
            return this;
        }

        public TweenParams SetEase(AnimationCurve curve)
        {
            return this;
        }
    }

    public static class Debugger
    {
        public static int logPriority;

        public static void Log(object message)
        {
        }

        public static void LogWarning(object message)
        {
        }

        public static void LogError(object message)
        {
        }
    }

    public static class TweenSettingsExtensions
    {
        public static T From<T>(this T tween, params object[] args) where T : Tween
        {
            return tween;
        }

        public static T SetAs<T>(this T tween, params object[] args) where T : Tween
        {
            return tween;
        }

        public static T SetOptions<T>(this T tween, params object[] args) where T : Tween
        {
            return tween;
        }

        public static T SetRelative<T>(this T tween, bool isRelative = true) where T : Tween
        {
            return tween;
        }

        public static T SetSpeedBased<T>(this T tween, bool isSpeedBased = true) where T : Tween
        {
            return tween;
        }
    }

    public static class ShortcutExtensions
    {
        public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<float, float, FloatOptions> DOFade(this Graphic target, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<float, float, FloatOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<float, float, FloatOptions> DOFade(this TMP_Text target, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<float, float, FloatOptions> DOFade(this Text target, float endValue, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
        {
            return new TweenerCore<Color, Color, ColorOptions>();
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
        {
            return new TweenerCore<Color, Color, ColorOptions>();
        }

        public static TweenerCore<Color, Color, ColorOptions> DOColor(this Material target, Color endValue, string property, float duration)
        {
            return new TweenerCore<Color, Color, ColorOptions>();
        }

        public static TweenerCore<float, float, FloatOptions> DOFloat(this Material target, float endValue, string property, float duration)
        {
            return new TweenerCore<float, float, FloatOptions>();
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
        {
            return new TweenerCore<Vector3, Vector3, VectorOptions>();
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOLocalMove(this Transform target, Vector3 endValue, float duration, bool snapping = false)
        {
            return new TweenerCore<Vector3, Vector3, VectorOptions>();
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Ignore, int resolution = 10, Color? gizmoColor = null)
        {
            return new TweenerCore<Vector3, Path, PathOptions>();
        }

        public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Transform target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Ignore, int resolution = 10, Color? gizmoColor = null)
        {
            return new TweenerCore<Vector3, Path, PathOptions>();
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, Vector3 endValue, float duration)
        {
            return new TweenerCore<Vector3, Vector3, VectorOptions>();
        }

        public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(this Transform target, float endValue, float duration)
        {
            return new TweenerCore<Vector3, Vector3, VectorOptions>();
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
        {
            return new TweenerCore<Quaternion, Vector3, QuaternionOptions>();
        }

        public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLocalRotate(this Transform target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
        {
            return new TweenerCore<Quaternion, Vector3, QuaternionOptions>();
        }

        public static Tweener DOShakePosition(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
        {
            return new Tweener();
        }

        public static Tweener DOShakeRotation(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
        {
            return new Tweener();
        }

        public static Tweener DOShakeScale(this Transform target, float duration, Vector3 strength, int vibrato = 10, float randomness = 90f, bool fadeOut = true)
        {
            return new Tweener();
        }

        public static Tweener DOPunchPosition(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
        {
            return new Tweener();
        }

        public static Tweener DOPunchRotation(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
        {
            return new Tweener();
        }

        public static Tweener DOPunchScale(this Transform target, Vector3 punch, float duration, int vibrato = 10, float elasticity = 1f)
        {
            return new Tweener();
        }

        public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
        {
            return new TweenerCore<Vector2, Vector2, VectorOptions>();
        }

        public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
        {
            return new TweenerCore<Vector2, Vector2, VectorOptions>();
        }

        public static TweenerCore<string, string, StringOptions> DOText(this TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            return new TweenerCore<string, string, StringOptions>();
        }

        public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, string scrambleChars = null)
        {
            return new TweenerCore<string, string, StringOptions>();
        }
    }
}

namespace DG.Tweening.Core
{
    public class TweenerCore<T1, T2, TPlugOptions> : DG.Tweening.Tweener
    {
        public T2 endValue;
        public TPlugOptions plugOptions;
    }
}

namespace DG.Tweening.Core.Easing
{
    public delegate float EaseFunction(float time, float duration, float overshootOrAmplitude, float period);

    public sealed class EaseCurve
    {
        private readonly AnimationCurve _curve;

        public EaseCurve(AnimationCurve curve)
        {
            _curve = curve;
        }

        public float Evaluate(float time, float duration, float overshootOrAmplitude, float period)
        {
            if (_curve == null)
            {
                return 0f;
            }

            if (duration == 0f)
            {
                return _curve.Evaluate(0f);
            }

            return _curve.Evaluate(time / duration);
        }
    }

    public static class EaseManager
    {
        public static float Evaluate(DG.Tweening.Ease ease, EaseFunction customEase, float time, float duration, float overshootOrAmplitude, float period)
        {
            if (ease == DG.Tweening.Ease.INTERNAL_Custom && customEase != null)
            {
                return customEase(time, duration, overshootOrAmplitude, period);
            }

            if (duration == 0f)
            {
                return 0f;
            }

            return time / duration;
        }
    }
}

namespace DG.Tweening.Plugins.Options
{
    public struct NoOptions
    {
    }

    public struct FloatOptions
    {
        public bool snapping;
    }

    public struct VectorOptions
    {
        public bool snapping;
        public DG.Tweening.AxisConstraint axisConstraint;
    }

    public struct ColorOptions
    {
        public bool alphaOnly;
    }

    public struct QuaternionOptions
    {
        public DG.Tweening.RotateMode rotateMode;
    }

    public struct StringOptions
    {
        public bool richTextEnabled;
        public DG.Tweening.ScrambleMode scrambleMode;
        public string scrambledChars;
    }

    public struct PathOptions
    {
        public DG.Tweening.AxisConstraint lockPositionAxis;
        public DG.Tweening.AxisConstraint lockRotationAxis;
    }
}

namespace DG.Tweening.Plugins.Core.PathCore
{
    public class Path
    {
        public Vector3[] wps;
    }
}
