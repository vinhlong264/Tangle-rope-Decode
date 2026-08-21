using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    public static T Instance { get; protected set; }

    protected virtual void OnInstanceCreated()
    {
    }

    protected virtual void OnInstanceDestroyed()
    {
    }
}

public class LevelData
{
}

public class LevelSystem : MonoBehaviour
{
    public UnityEvent<LevelData> OnLoadFinished;
}

public interface IElephantStorage
{
}

public class Joystick : MonoBehaviour
{
    public float Horizontal => 0f;

    public float Vertical => 0f;
}

public static class RollicInterstitialAd
{
    public enum InterstitialAdSource
    {
        Unknown
    }
}

public static class RollicRewardedAd
{
    public enum RewardedAdCategory
    {
        Unknown
    }

    public enum RewardedAdSource
    {
        Unknown
    }
}

public class SceneReference
{
    public string SceneName;
}

public class SceneField
{
    public string SceneName;
}

namespace NaughtyAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    public sealed class ShowIfAttribute : PropertyAttribute
    {
        public ShowIfAttribute(string condition)
        {
        }
    }
}

namespace SRDebugger
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IncrementAttribute : Attribute
    {
        public IncrementAttribute(double increment)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class NumberRangeAttribute : Attribute
    {
        public NumberRangeAttribute(double min, double max)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class SortAttribute : Attribute
    {
        public SortAttribute(int priority)
        {
        }
    }
}

namespace AdjustSdk
{
    public class AdjustAttribution
    {
    }
}

namespace RollicGames.Advertisements
{
    public sealed class RLAdvertisementManager
    {
    }

    public sealed class RLRewardedAdResult
    {
    }

    public static class RollicInterstitialAd
    {
        public enum InterstitialAdSource
        {
            Unknown
        }
    }

    public static class RollicRewardedAd
    {
        public enum RewardedAdCategory
        {
            Unknown
        }

        public enum RewardedAdSource
        {
            Unknown
        }
    }
}

namespace DevLocker.Utils
{
    [Serializable]
    public class SceneReference
    {
        public string SceneName;
    }

    [Serializable]
    public class SceneField
    {
        public string SceneName;
    }
}

namespace Utility.SLayout
{
    public class SLayoutGroup : LayoutGroup
    {
        public override void CalculateLayoutInputHorizontal()
        {
        }

        public override void CalculateLayoutInputVertical()
        {
        }

        public override void SetLayoutHorizontal()
        {
        }

        public override void SetLayoutVertical()
        {
        }
    }
}

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class SimpleScrollSnap : MonoBehaviour
    {
        public int NumberOfPanels => 0;
        public int CurrentPanel => 0;

        public void GoToPanel(int panelNumber)
        {
        }
    }
}

namespace BrunoMikoski.AnimationSequencer
{
    using DG.Tweening;

    [Serializable]
    public class CustomEase
    {
        public Ease ease = Ease.Linear;
    }

    public class AnimationSequencerController : MonoBehaviour
    {
        public void Play()
        {
        }

        public void Stop()
        {
        }
    }

    public abstract class DOTweenActionBase : MonoBehaviour
    {
        public abstract Type TargetComponentType { get; }

        public abstract string DisplayName { get; }

        public virtual void ResetToInitialState()
        {
        }

        protected abstract Tweener GenerateTween_Internal(GameObject target, float duration);
    }
}

namespace Spine.Unity
{
    public class SkeletonDataAsset : ScriptableObject
    {
    }

    public class SkeletonGraphic : MaskableGraphic
    {
        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
        }
    }

    public class SkeletonAnimation : MonoBehaviour
    {
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class SpineAnimationAttribute : PropertyAttribute
    {
        public SpineAnimationAttribute(string startsWith = null, string dataField = null, bool includeNone = false, bool fallbackToTextField = false, bool clipNameAsValue = false)
        {
        }
    }
}

namespace Shapes
{
    public class ShapeRenderer : MonoBehaviour
    {
        public Color Color;
    }

    public class ShapeGroup : MonoBehaviour
    {
        public float Opacity;
    }

    public class Disc : ShapeRenderer
    {
    }

    public class Rectangle : ShapeRenderer
    {
    }
}

namespace Coffee.UIEffects
{
    public class UIGradient : MonoBehaviour
    {
        public enum Direction
        {
            Horizontal,
            Vertical,
            Angle,
            Diagonal
        }

        public Direction direction;
        public float rotation;
        public float offset1;
        public Vector2 offset2;
        public Color color1;
        public Color color2;
        public Color color3;
        public Color color4;
    }

    public class UIShiny : MonoBehaviour
    {
    }
}

namespace Obi
{
    public class ObiActor : MonoBehaviour
    {
    }

    public class ObiRope : ObiActor
    {
    }

    public class ObiSolver : MonoBehaviour
    {
        public sealed class ObiCollisionEventArgs : EventArgs
        {
        }
    }

    public class ObiParticleAttachment : MonoBehaviour
    {
    }

    public class ObiColliderBase : MonoBehaviour
    {
    }

    public class ObiRopeCursor : MonoBehaviour
    {
    }

    public class ObiRopeExtrudedRenderer : MonoBehaviour
    {
    }

    public class ObiRopeChainRenderer : MonoBehaviour
    {
    }

    public class ObiStructuralElement
    {
    }
}

namespace Oni
{
    public struct Contact
    {
    }
}

namespace ElephantSDK
{
    public enum ElephantEnvironment
    {
        Development,
        Production
    }

    public class GenericResponse<T>
    {
        public T Data;
        public string Error;
        public bool Success;
    }

    public class OfferData
    {
        public string Name;
    }

    public interface IElephantAdapter
    {
    }

    public interface IFacebookElephantAdapter : IElephantAdapter
    {
    }

    public interface IFirebaseElephantAdapter : IElephantAdapter
    {
    }

    public interface IHelpShiftElephantAdapter : IElephantAdapter
    {
    }

    public interface IAdjustElephantAdapter : IElephantAdapter
    {
    }

    public interface ILiveOpsElephantAdapter : IElephantAdapter
    {
    }

    public interface IPushElephantAdapter : IElephantAdapter
    {
    }

    public class BaseData
    {
    }

    public class Params
    {
    }

    public class MetaDataUtils
    {
    }

    public class Offer
    {
    }

    public class OfferUiUrls
    {
    }

    public class OfferMetaData
    {
    }

    public class OfferUIData
    {
    }

    public class PurchaseOption
    {
    }

    public class ComponentData
    {
    }

    public class ContainerData
    {
    }

    public class Pair
    {
    }

    public class RemoteConfig
    {
    }
}

public static class MaxSdkBase
{
    public sealed class AdInfo
    {
        public string AdUnitIdentifier;
        public string NetworkName;
        public string Placement;
        public string RevenuePrecision;
        public string DspName;
        public string NetworkPlacement;
        public string CountryCode;
        public string CreativeIdentifier;
        public double Revenue;
    }
}

namespace Google.Play.Common
{
    public struct VoidResult
    {
    }

    public class PlayAsyncOperation<TResult, TError>
    {
        public bool IsDone => true;
        public TResult GetResult()
        {
            return default;
        }
    }
}

namespace Google.Play.Review
{
    using Google.Play.Common;

    public enum ReviewErrorCode
    {
        NoError
    }

    public sealed class PlayReviewInfo
    {
    }

    public sealed class ReviewManager
    {
        public PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> RequestReviewFlow()
        {
            return new PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode>();
        }

        public PlayAsyncOperation<VoidResult, ReviewErrorCode> LaunchReviewFlow(PlayReviewInfo reviewInfo)
        {
            return new PlayAsyncOperation<VoidResult, ReviewErrorCode>();
        }
    }
}

namespace UnityEngine.Localization
{
    using UnityEngine.Events;

    [Serializable]
    public class Locale : ScriptableObject
    {
        public LocaleIdentifier Identifier;
    }

    [Serializable]
    public struct LocaleIdentifier
    {
        public LocaleIdentifier(string code)
        {
            Code = code;
        }

        public string Code { get; }
    }

    [Serializable]
    public class LocalizedString
    {
        public delegate void ChangeHandler(string value);

        public string TableReference;
        public string TableEntryReference;

        public string GetLocalizedString()
        {
            return null;
        }

        public void RefreshString()
        {
        }

        public void AddChangeHandler(ChangeHandler handler)
        {
        }

        public void RemoveChangeHandler(ChangeHandler handler)
        {
        }
    }

    [Serializable]
    public class LocalizedAsset<T> where T : UnityEngine.Object
    {
        public string TableReference;
        public string TableEntryReference;

        public void LoadAssetAsync()
        {
        }

        public void AddChangeHandler(Action<T> handler)
        {
        }

        public void RemoveChangeHandler(Action<T> handler)
        {
        }
    }

    [Serializable]
    public class LocalizedSprite : LocalizedAsset<Sprite>
    {
    }
}

namespace UnityEngine.Localization.Settings
{
    using System.Collections.Generic;
    using UnityEngine.Localization;

    public interface ILocalesProvider
    {
        IEnumerable<Locale> Locales { get; }
    }

    public interface IStartupLocaleSelector
    {
        Locale GetStartupLocale(ILocalesProvider availableLocales);
    }

    public static class LocalizationSettings
    {
        public static Locale SelectedLocale { get; set; }
    }
}

namespace UnityEngine.Localization.Components
{
    public class LocalizedAssetEvent<TObject, TReference, TUnityEvent> : MonoBehaviour
        where TObject : UnityEngine.Object
        where TReference : UnityEngine.Localization.LocalizedAsset<TObject>, new()
        where TUnityEvent : UnityEvent<TObject>, new()
    {
        public TReference AssetReference = new TReference();
        public TUnityEvent UpdateAsset = new TUnityEvent();
    }
}

namespace Crescive.Localization
{
    using TMPro;
    using UnityEngine;
    using UnityEngine.Localization;

    [Serializable]
    public class LocalizedTmpFont : LocalizedAsset<TMP_FontAsset>
    {
    }
}

namespace Crescive.Interactables
{
    [Serializable]
    public class CollisionUnityEvent : UnityEvent<Collision>
    {
    }

    [Serializable]
    public class ColliderUnityEvent : UnityEvent<Collider>
    {
    }
}

namespace Crescive.Levels.Save
{
    public abstract class LevelSaveManager : ScriptableObject
    {
        public abstract void SaveLevel(int levelNumber, int levelIndex);

        public abstract void SaveLevelNumber(int levelNumber);

        public abstract int GetLevelNumber();

        public abstract void SaveLevelIndex(int index);

        public abstract int GetLevelIndex();

        public abstract void SaveHighestLevelNumber(int levelNumber);

        public abstract int GetHighestLevelNumber();
    }
}

namespace ElephantSDK
{
    public class CurrencyAmount
    {
    }

    public class IapVerifyRequest
    {
    }
}
