using System;
using System.Runtime.CompilerServices;

namespace ElephantUniTask.Threading.Tasks
{
    [AsyncMethodBuilder(typeof(CompilerServices.AsyncUniTaskMethodBuilder))]
    public readonly struct UniTask
    {
        public Awaiter GetAwaiter()
        {
            return default;
        }

        public readonly struct Awaiter : ICriticalNotifyCompletion
        {
            public bool IsCompleted => true;

            public void GetResult()
            {
            }

            public void OnCompleted(Action continuation)
            {
                continuation?.Invoke();
            }

            public void UnsafeOnCompleted(Action continuation)
            {
                continuation?.Invoke();
            }
        }
    }

    [AsyncMethodBuilder(typeof(CompilerServices.AsyncUniTaskVoidMethodBuilder))]
    public readonly struct UniTaskVoid
    {
    }

    [AsyncMethodBuilder(typeof(CompilerServices.AsyncUniTaskMethodBuilder<>))]
    public readonly struct UniTask<T>
    {
        public Awaiter GetAwaiter()
        {
            return default;
        }

        public readonly struct Awaiter : ICriticalNotifyCompletion
        {
            public bool IsCompleted => true;

            public T GetResult()
            {
                return default;
            }

            public void OnCompleted(Action continuation)
            {
                continuation?.Invoke();
            }

            public void UnsafeOnCompleted(Action continuation)
            {
                continuation?.Invoke();
            }
        }
    }

    public sealed class UniTaskCompletionSource<T>
    {
        public UniTask<T> Task => default;

        public bool TrySetResult(T result)
        {
            return true;
        }

        public bool TrySetException(Exception exception)
        {
            return true;
        }

        public bool TrySetCanceled()
        {
            return true;
        }
    }
}

namespace ElephantUniTask.Threading.Tasks.CompilerServices
{
    public struct AsyncUniTaskMethodBuilder
    {
        public static AsyncUniTaskMethodBuilder Create()
        {
            return default;
        }

        public ElephantUniTask.Threading.Tasks.UniTask Task => default;

        public void SetException(Exception exception)
        {
        }

        public void SetResult()
        {
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }
    }

    public struct AsyncUniTaskMethodBuilder<T>
    {
        public static AsyncUniTaskMethodBuilder<T> Create()
        {
            return default;
        }

        public ElephantUniTask.Threading.Tasks.UniTask<T> Task => default;

        public void SetException(Exception exception)
        {
        }

        public void SetResult(T result)
        {
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }
    }

    public struct AsyncUniTaskVoidMethodBuilder
    {
        public static AsyncUniTaskVoidMethodBuilder Create()
        {
            return default;
        }

        public ElephantUniTask.Threading.Tasks.UniTaskVoid Task => default;

        public void SetException(Exception exception)
        {
        }

        public void SetResult()
        {
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
        }
    }
}
