select
    TO_CHAR(trans_date, 'YYYY-MM') as "month",
    country,
    count(*) as "trans_count",
    COALESCE(COUNT(*) FILTER (WHERE state = 'approved'), 0) AS approved_count,
    COALESCE(SUM(amount), 0) AS trans_total_amount,
    COALESCE(SUM(amount) FILTER (WHERE state = 'approved'), 0) AS approved_total_amount
from transactions
group by country, TO_CHAR(trans_date, 'YYYY-MM')
order by month