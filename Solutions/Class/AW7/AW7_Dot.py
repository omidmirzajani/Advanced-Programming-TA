import math
class Dot:
    def __init__(self,x,y):
        self.X = x
        self.Y = y
    def Distance(self,other):
        differentX = (self.X - other.X) * (self.X - other.X)
        differentY = (self.Y - other.Y) * (self.Y - other.Y)
        return math.sqrt(differentX + differentY)
    def __eq__(self, other):
        return (self.X == other.X) and (self.Y == other.Y)