namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes = new List<VisitRoute>();

        public void AddVisitRoute(VisitRoute visitRoute)
        {
            visitRoutes.Add(visitRoute);
        }
      
        public int VisitRouteCount { get=>visitRoutes.Count;}
      
        public IIterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
