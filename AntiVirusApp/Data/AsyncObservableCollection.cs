using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Threading;

namespace AntiVirusApp.Data
{
	class AsyncObservableCollection<T> : ObservableCollection<T>
	{
		private SynchronizationContext _syncContext = SynchronizationContext.Current;

		#region CTORs
		public AsyncObservableCollection()
		{

		}

		public AsyncObservableCollection(IEnumerable<T> list) : base(list)
		{

		}
		#endregion

		#region Override ObservableCollection events
		protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
		{
			if ((_syncContext == SynchronizationContext.Current) && (_syncContext != null))
			{
                //在当前线程执行CollectionChanged事件
                RunCollectionChanged(e);
			}
			else if (_syncContext != null)
			{
                //在创建者线程执行CollectionChanged事件
                _syncContext.Send(RunCollectionChanged, e);
			}
		}

		protected override void OnPropertyChanged(PropertyChangedEventArgs e)
		{
            if ((_syncContext == SynchronizationContext.Current) && (_syncContext != null))
            {
                //在当前线程执行PropertyChanged事件
                RunPropertyChanged(e);
			}
            else if (_syncContext != null)
            {
                //在创建者线程执行PropertyChanged事件
                _syncContext.Send(RunPropertyChanged, e);
			}
		}
		#endregion

		#region Event runners
		private void RunCollectionChanged(object arg)
		{
            //创建者线程: 执行基类实例
            base.OnCollectionChanged((NotifyCollectionChangedEventArgs)arg);
		}

		private void RunPropertyChanged(object arg)
		{
            //创建者线程: 执行基类实例
            base.OnPropertyChanged((PropertyChangedEventArgs)arg);
		}
		#endregion
	}
}
