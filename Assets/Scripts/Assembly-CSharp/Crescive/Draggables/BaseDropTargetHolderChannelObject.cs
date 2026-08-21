using Crescive.Channels;

namespace Crescive.Draggables
{
	public abstract class BaseDropTargetHolderChannelObject<TChannel, TData> : ChannelObject<TChannel, TData> where TChannel : BaseDropTargetHoldersChannel<TData> where TData : BaseDropTargetHolder
	{
	}
}
