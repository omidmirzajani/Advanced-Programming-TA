import AW7_Dot
import AW7_Triangle

class Shape:
    def __init__(self,dots):
        self.Dots = dots

    def Area(self):
        area=0
        for i in range (1,len(self.Dots)-1):
            dots = [self.Dots[0] , self.Dots[i] , self.Dots[i+1]]
            t = AW7_Triangle.Triangle(dots)
            area += t.Area()
        return area

    def Surroundings(self):
        surroundings = 0
        for i in range(len(self.Dots)-1):
            surroundings += self.Dots[i].Distance(self.Dots[i+1])
        surroundings += self.Dots[0].Distance(self.Dots[-1])
        return surroundings

    def __iadd__(self, other):
        for dot in other.Dots:
            if(dot not in self.Dots):
                self.Dots.append(dot)
        return self
            
    def __eq__(self, other):
        return self.Dots == other.Dots
            