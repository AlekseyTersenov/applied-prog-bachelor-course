class Point

	attr_accessor :x, :y

	def initialize(x = 0, y = 0)
		@x = x
		@y = y
	end

	def eql?(point) 
		if ((@x == point.x) && (@y == point.y))
			return true
		else
			return false
		end
	end

	def to_s()
	 	"x=#{@x}\ny=#{@y}"
	end

end