import math
class Triangle:
    def __init__(self,dots):
        self.Dots = dots
    
    def Surroundings(self):
        surronding = 0
        surronding += self.Dots[0].Distance(self.Dots[1])
        surronding += self.Dots[1].Distance(self.Dots[2])
        surronding += self.Dots[2].Distance(self.Dots[0])
        return surronding
    
    def Area(self): 
        a = self.Dots[0].Distance(self.Dots[1])
        b = self.Dots[1].Distance(self.Dots[2])
        c = self.Dots[2].Distance(self.Dots[0])
        p = (a + b + c) / 2
        s = p * (p - a) * (p - b) * (p - c)
        return math.sqrt(s)

    def __eq__(self,other):
        return self.Dots == other.Dots


