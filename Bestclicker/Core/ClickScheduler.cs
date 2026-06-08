using System;
using System.Threading;
using System.Threading.Tasks;

namespace AutoClicker.Core
{
    internal class ClickScheduler : IDisposable
    {
        private CancellationTokenSource? _cts;
        private Task? _task;
        private bool _disposed = false;

        public bool IsRunning => _task != null && !_task.IsCompleted;

        public void Start(int intervalMs, Action action)
        {
            Stop();
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;
            _task = Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    action();
                    try
                    {
                        await Task.Delay(intervalMs, token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
            }, token);
        }

        public void Stop()
        {
            if (_cts != null)
            {
                _cts.Cancel();
                try { _task?.Wait(500); } catch { }
                _cts.Dispose();
                _cts = null;
                _task = null;
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                Stop();
                _disposed = true;
            }
        }
    }
}