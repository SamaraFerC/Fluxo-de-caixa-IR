function confirmDelete(cashFlowID) {
    const userConfirmed = confirm("Tem certeza de que deseja inativar esta movimentação?");

    if (userConfirmed) {
        $.ajax({
            url: '/CashFlow/Edit',
            type: 'POST',
            data: { id: cashFlowID },
            success: function (response) {
                if (response.success) {
                    const row = document.getElementById(`row-${cashFlowID}`);
                    if (row) row.remove();
                    alert("Movimentação Inativada com sucesso.");
                } else {
                    alert("Falha inativar esta movimentação.");
                }
            },
            error: function () {
                alert("Ocorreu um erro ao tentar inativar esta movimentação.");
            }
        });
    }
}