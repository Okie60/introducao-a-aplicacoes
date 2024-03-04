switch (true) {
                case var _ when valor1 > valor2 && valor1 > valor3:
                    maior = valor1;
                    lblSoma.Text = "O número " + maior.ToString() + " é maior";
                    break;
                case var _ when valor1 < valor2 && valor2 > valor3:
                    maior = valor2;
                    lblSoma.Text = "O número " + maior.ToString() + " é maior";
                    break;
                case var _ when valor3 > valor1 && valor3 > valor2:
                    maior = valor3;
                    lblSoma.Text = "O número " + maior.ToString() + " é maior";
                    break;
                case var _ when valor1 == valor2 && valor1 != valor3:
                    MessageBox.Show("Dois números iguais. " + valor1, "Valores iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor1.Text = "";
                    txtValor2.Text = "";
                    txtValor3.Text = "";
                    lblSoma.Text = "";
                    txtValor1.Focus();
                    break;
                case var _ when valor2 == valor3 && valor2 != valor1:
                    MessageBox.Show("Dois números iguais. " + valor2, "Valores iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor1.Text = "";
                    txtValor2.Text = "";
                    txtValor3.Text = "";
                    lblSoma.Text = "";
                    txtValor1.Focus();
                    break;
                case var _ when valor1 == valor3 && valor1 != valor2:
                    MessageBox.Show("Dois números iguais. " + valor1, "Valores iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtValor1.Text = "";
                    txtValor2.Text = "";
                    txtValor3.Text = "";
                    lblSoma.Text = "";
                    txtValor1.Focus();
                    break;
                default:
                    if (valor1 ==  valor2 && valor2 == valor3)
                    {
                        MessageBox.Show("Todos os números iguais. " + valor1.ToString(), "Valores iguais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValor1.Text = "";
                        txtValor2.Text = "";
                        txtValor3.Text = "";
                        lblSoma.Text = "";
                        txtValor1.Focus();
                    }
                    break;
            }

// por algum motivo n consegui fazer o pull pelo visual studio, ent estou atualizando por esse read me
