using Crescive.Channels;

namespace Crescive.Draggables
{
	public abstract class BaseDropTargetHoldersChannelSetup<TChannel, THolder> : ObjectsChannelSetup<TChannel, THolder> where TChannel : BaseDropTargetHoldersChannel<THolder> where THolder : BaseDropTargetHolder
	{
	}
}
