select query_name,
       round(avg(rating * 1.0 / position), 2) as "quality",
       round((100.0 * count(rating) filter ( where rating < 3 ) ) / count(rating), 2) as "poor_query_percentage"
from queries
group by query_name
