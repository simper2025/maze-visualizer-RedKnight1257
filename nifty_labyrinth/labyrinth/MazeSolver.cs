namespace labyrinth;

public class MazeSolver
{
    public List<NodeLink> ExploreMaze(MazeCell start)
    {
        List<NodeLink> visitedNodes = [];

        start.WhatsHere = Item.Start;

        ExploreNode(start, visitedNodes);

        return visitedNodes;
    }

    public void ExploreNode(MazeCell current, List<NodeLink> visited)
    {
        if (current == null)
            return;

        // if start.North is not null
        // make new NodeLink from start going N to start.North
        // if list of visited nodes does not contain new NodeLink
        //     add new NodeLink to list of visited nodes
        //     call exploreNode passing start.North

        if (current.North != null)
        {
            var link = new NodeLink(current, "N", current.North);

            if (!visited.Contains(link))
            {
                visited.Add(link);
                ExploreNode(current.North, visited);
            }
        }
        if (current.East != null)
        {
            var link = new NodeLink(current, "E", current.East);

            if (!visited.Contains(link))
            {
                visited.Add(link);
                ExploreNode(current.East, visited);
            }
        }
        if (current.South != null)
        {
            var link = new NodeLink(current, "S", current.South);

            if (!visited.Contains(link))
            {
                visited.Add(link);
                ExploreNode(current.South, visited);
            }
        }
        if (current.West != null)
        {
            var link = new NodeLink(current, "W", current.West);

            if (!visited.Contains(link))
            {
                visited.Add(link);
                ExploreNode(current.West, visited);
            }
        }
        
    }
}