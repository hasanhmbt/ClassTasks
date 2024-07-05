


Declare @numberdata nvarchar(50) ='+994(50)221-23-45'

Declare @countrycode nvarchar(50)
Declare @operator nvarchar(50)
Declare @Number nvarchar(50)

set @countrycode  = LEFT(@numberdata, CHARINDEX('(',@numberdata)-1)  
set @operator     = Substring(@numberdata,CHARINDEX('(',@numberdata)+1,CHARINDEX(')',@numberdata)-CHARINDEX('(',@numberdata)-1)   
set @Number       = RIGHT(@numberdata, CHARINDEX(')',@numberdata))   

print'Code:'+@countrycode+'	Operator:'+@operator+'	Number:'+@Number
 














